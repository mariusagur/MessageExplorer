using McTools.Xrm.Connection;
using MessageExplorer.Models;
using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MessageExplorer
{
    public partial class EntityExplorer : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        #region Interface variables
        string IGitHubPlugin.RepositoryName => "MessageExplorer";
        string IGitHubPlugin.UserName => "mariusagur";
        public string HelpUrl => "https://github.com/mariusagur/MessageExplorer/wiki";
        #endregion

        private Settings mySettings;
        private MessageHierarchyModel data;
        private DataFactory entityHelper;
        private BindingList<string> entityData = new BindingList<string>();
        private BindingList<MessageModel> messageData = new BindingList<MessageModel>();
        private BindingList<SubscriberModel> subscriberData = new BindingList<SubscriberModel>();
        public EntityExplorer()
        {
            InitializeComponent();
            entityHelper = new DataFactory(Service);
        }

        private void MessageExplorer_Load(object sender, EventArgs e)
        {
            // Loads or creates the settings for the plugin
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();

                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            if (Service != null)
            {
                InstantiateData();
            }
        }

        private void InstantiateData()
        {
            WorkAsync(new WorkAsyncInfo($"Baby shark, doo doo doo doo doo doo",
                    (eventargs) =>
                    {
                        entityHelper = new DataFactory(Service);
                        data = entityHelper.Data;
                    })
            {
                PostWorkCallBack = (completedargs) =>
                {
                    EntityListBox.DataSource = entityData;
                    MessageView.DataSource = messageData;
                    SubscriberListBox.DataSource = subscriberData;
                    SubscriberListBox.DisplayMember = "SubscriberName";
                    SubscriberListBox.ValueMember = "Id";

                    UpdateMessageColumns();

                    UpdateEntityData();
                }
            });
        }

        private void UpdateMessageColumns()
        {
            if (!MessageView.Columns.Contains("IncludeMessage"))
            {
                MessageView.Columns.Add(this.includeMessageCheckBoxColumn);
            }
            if (MessageView.Columns.Contains("Id"))
            {
                MessageView.Columns["Id"].ReadOnly = true;
                MessageView.Columns["Id"].DisplayIndex = 1;
            }
            if (MessageView.Columns.Contains("MessageName"))
            {
                MessageView.Columns["MessageName"].ReadOnly = true;
                MessageView.Columns["MessageName"].HeaderText = "Name";
                MessageView.Columns["MessageName"].DisplayIndex = 2;
            }
            if (MessageView.Columns.Contains("Entity"))
            {
                MessageView.Columns["Entity"].ReadOnly = true;
                MessageView.Columns["Entity"].DisplayIndex = 3;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void MessageExplorer_ConnectionUpdated(object sender, EventArgs e)
        {
            MessageExplorer_Load(sender, e);
        }

        /// <summary>
        /// This event occurs when the plugin is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }

        private void AddSubscribers(Guid messageId)
        {
            var subscribers = data.Subscribers.Where(s => s.Message.Id == messageId);
            foreach (var subscriber in subscribers)
            {
                subscriberData.Add(subscriber);
            }
        }

        private void RemoveSubscribers(Guid messageId)
        {
            var subsToRemove = subscriberData.Where(s => s.Message.Id == messageId).ToList();
            foreach (var s in subsToRemove)
            {
                if (s.Message.Id == messageId)
                {
                    subscriberData.Remove(s);
                }
            }
        }

        private void UpdateEntityData()
        {
            entityData.Clear();
            if (data != null)
            {
                IEnumerable<string> entities;
                if (string.IsNullOrWhiteSpace(EntitySearchBox.Text))
                {
                    entities = data.Entities.Where(e => e.Value || entityCheckBox.Checked).Select(e => e.Key);
                }
                else
                {
                    entities = data.Entities.Where(
                        e =>
                            (e.Value || entityCheckBox.Checked) &&
                            e.Key.IndexOf(EntitySearchBox.Text, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                        .Select(e => e.Key);
                }
                foreach (var entity in entities)
                {
                    entityData.Add(entity);
                }
            }
        }

        private void AddMessage(string entity)
        {
            subscriberData.Clear();
            var messages = data.Messages.Where(
                m =>
                    (m.Value || messageCheckBox.Checked)
                    && m.Key.Entity == entity)
                .Select(m => m.Key);

            foreach (var m in messages)
            {
                messageData.Add(m);
            }
        }
        private void RemoveMessage(string entity)
        {
            var messagesToRemove = messageData.Where(m => m.Entity == entity).ToList();
            foreach (var m in messagesToRemove)
            {
                RemoveSubscribers(m.Id);
                messageData.Remove(m);
            }
        }

        private void EntityCheckBox_Changed(object sender, EventArgs e)
        {
            UpdateEntityData();
        }

        private void MessageCheckBox_Changed(object sender, EventArgs e)
        {
            messageData.Clear();
            foreach (var m in EntityListBox.CheckedItems)
            {
                AddMessage((string)m);
            }
        }

        private void MessageListBox_SelectedIndexChanged(object sender, ItemCheckEventArgs e)
        {
            var checkedMessage = ((CheckedListBox)sender).Items[e.Index] as MessageModel;

            if (e.NewValue == CheckState.Checked)
            {
                AddSubscribers(checkedMessage.Id);
            }
            else
            {
                RemoveSubscribers(checkedMessage.Id);
            }
        }

        private void EntityListBox_SelectedIndexChanged(object sender, ItemCheckEventArgs e)
        {
            var checkedEntity = ((CheckedListBox)sender).Items[e.Index] as string;

            if (e.NewValue == CheckState.Checked)
            {
                AddMessage(checkedEntity);
            }
            else
            {
                RemoveMessage(checkedEntity);
            }
        }

        private void EntitySearchBox_Search(object sender, EventArgs e)
        {
            UpdateEntityData();
        }

        void SubscriberListBox_MouseDoubleClick(object sender, EventArgs e)
        {
            int index = SubscriberListBox.IndexFromPoint(((MouseEventArgs)e).Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(JsonConvert.SerializeObject(SubscriberListBox.Items[index], Formatting.Indented));
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            InstantiateData();
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            var exportForm = new ExportSubscribers(subscriberData.ToList());
            exportForm.ShowDialog();
        }

        private void MessageView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (((DataGridView)sender).CurrentCell.GetType() == typeof(DataGridViewCheckBoxCell))
            {
                MessageView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void MessageView_IncludeChanged(object sender, DataGridViewCellEventArgs e)
        {
            Console.WriteLine("I am saved");
        }
    }
}
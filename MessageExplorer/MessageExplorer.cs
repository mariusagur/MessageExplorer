using McTools.Xrm.Connection;
using MessageExplorer.Models;
using Microsoft.Xrm.Sdk;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace MessageExplorer
{
    public partial class MessageSubscriber : PluginControlBase
    {
        private Settings mySettings;
        private MessageHierarchyModel data;
        private DataFactory entityHelper;
        private BindingList<string> entityData = new BindingList<string>();
        private BindingList<MessageModel> messageData = new BindingList<MessageModel>();
        private BindingList<SubscriberModel> subscriberData = new BindingList<SubscriberModel>();

        public MessageSubscriber()
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

                entityHelper = new DataFactory(Service);
                data = entityHelper.Data;

                UpdateEntityData();

                entityListBox.DataSource = entityData;
                messageListBox.DataSource = messageData;
                messageListBox.ValueMember = "Id";
                messageListBox.DisplayMember = "MessageName";
                subscriberListBox.DataSource = subscriberData;
                subscriberListBox.DisplayMember = "SubscriberName";
                subscriberListBox.ValueMember = "Id";
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

        private void UpdateSubscriberData()
        {
            subscriberData.Clear();
            if (messageListBox.SelectedItem != null)
            {
                var subscribers = data.Subscribers.Where(s => s.Message == messageListBox.SelectedItem);
                foreach (var subscriber in subscribers)
                {
                    subscriberData.Add(subscriber);
                }
            }
        }

        private void UpdateMessageData()
        {
            messageData.Clear();
            var messages = data.Messages.Where(m => (m.Value || messageCheckBox.Checked) && m.Key.Entity == (string)entityListBox.SelectedItem).Select(m => m.Key);
            foreach (var message in messages)
            {
                messageData.Add(message);
            }

            UpdateSubscriberData();
        }


        private void UpdateEntityData()
        {
            entityData.Clear();
            if (data != null)
            {
                var entities = data.Entities.Where(e => e.Value || entityCheckBox.Checked).Select(e => e.Key);
                foreach (var entity in entities)
                {
                    entityData.Add(entity);
                }
            }

            UpdateMessageData();
        }

        private void EntityCheckBox_Changed(object sender, EventArgs e)
        {
            UpdateEntityData();
        }

        private void MessageCheckBox_Changed(object sender, EventArgs e)
        {
            UpdateMessageData();
        }

        private void MessageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubscriberData();
        }

        private void EntityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMessageData();
        }

        void SubscriberListBox_MouseDoubleClick(object sender, EventArgs e)
        {
            int index = subscriberListBox.IndexFromPoint(((MouseEventArgs)e).Location);
            if (index != ListBox.NoMatches)
            {
                MessageBox.Show(JsonConvert.SerializeObject(subscriberListBox.Items[index], Formatting.Indented));
            }
        }
    }
}
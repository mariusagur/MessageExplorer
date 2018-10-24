using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk;
using McTools.Xrm.Connection;

namespace MessageExplorer
{
    public partial class MessageSubscriber : PluginControlBase
    {
        private Settings mySettings;
        private MessageHierarchyModel data;
        private EntityHelper entityHelper;
        private BindingList<string> entityData = new BindingList<string>();
        private BindingList<KeyValuePair<Guid, string>> messageData = new BindingList<KeyValuePair<Guid, string>>();
        private BindingList<string> subscriberData = new BindingList<string>();

        public MessageSubscriber()
        {
            InitializeComponent();
            entityHelper = new EntityHelper(Service);
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
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
            entityHelper = new EntityHelper(Service);
            data = entityHelper.GetData();

            UpdateEntityData();

            entityListBox.DataSource = entityData;
            messageListBox.DataSource = messageData;
            messageListBox.ValueMember = "Key";
            messageListBox.DisplayMember = "Value";
            subscriberListBox.DataSource = subscriberData;
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
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
                var message = (KeyValuePair<Guid, string>)messageListBox.SelectedItem;
                if (data.Subscribers.ContainsKey(message.Key))
                {
                    var subscriber = data.Subscribers[((KeyValuePair<Guid, string>)messageListBox.SelectedItem).Key];
                    foreach (var sub in subscriber)
                    {
                        subscriberData.Add(sub);
                    }
                }
            }
        }

        private void UpdateMessageData()
        {
            var entity = (string)entityListBox.SelectedItem;
            messageData.Clear();
            if (entity != null)
            {
                if (messageCheckBox.Checked)
                {
                    foreach (var message in data.Messages[entity])
                    {
                        messageData.Add(message);
                    }
                }
                else
                {
                    var validMessages = data.Messages[entity].Where(msg => data.Subscribers.ContainsKey(msg.Key)).ToList();
                    foreach (var message in validMessages)
                    {
                        messageData.Add(message);
                    }
                }
            }

            UpdateSubscriberData();
        }


        private void UpdateEntityData()
        {
            if (data != null)
            {
                if (entityCheckBox.Checked)
                {
                    entityData = new BindingList<string>(data.Entities.Where(d => d.Value == false).Select(d => d.Key).ToList());
                }
                else
                {
                    entityData = new BindingList<string>(data.Entities.Where(d => d.Value == true).Select(d => d.Key).ToList());
                }
            }

            UpdateMessageData();
        }

        private void entityCheckBox_changed(object sender, EventArgs e)
        {
            UpdateEntityData();
        }

        private void messageCheckBox_changed(object sender, EventArgs e)
        {
            UpdateMessageData();
        }

        private void messageListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSubscriberData();
        }

        private void entityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateMessageData();
        }
    }
}
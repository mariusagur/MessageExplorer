using MessageExplorer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MessageExplorer
{
    public partial class ExportSubscribers : Form
    {
        private readonly List<SubscriberModel> data;
        private Dictionary<string, List<object>> entitiesAndMessages = new Dictionary<string, List<object>>();
        private Dictionary<string, List<object>> entitiesAndSubscribers = new Dictionary<string, List<object>>();
        private Dictionary<Guid, Dictionary<string, object>> messages = new Dictionary<Guid, Dictionary<string, object>>();
        private Dictionary<Guid, Dictionary<string, object>> subscribers = new Dictionary<Guid, Dictionary<string, object>>();
        private string separator = "\t";
        private string attributeSeparator = ";";

        public ExportSubscribers(List<SubscriberModel> subscribers)
        {
            data = subscribers;
            InitializeComponent();
            BuildEntityHierarchy();
            BuildOutput();
        }

        private void BuildEntityHierarchy()
        {
            foreach (var sub in data)
            {
                if (!entitiesAndMessages.ContainsKey(sub.Entity))
                {
                    entitiesAndMessages.Add(sub.Entity, new List<object>());
                }
                if (!entitiesAndSubscribers.ContainsKey(sub.Entity))
                {
                    entitiesAndSubscribers.Add(sub.Entity, new List<object>());
                }
                if (!messages.ContainsKey(sub.Message.Id))
                {
                    var messageDict = new Dictionary<string, object>
                    {
                        { MessageNameCheckBox.Text, sub.Message.MessageName },
                        { MessageIdCheckBox.Text, sub.Message.Id },
                        { MessageEntityCheckBox.Text, sub.Message.Entity },
                        { "Subscribers", new List<object>() }
                    };

                    messages.Add(sub.Message.Id, messageDict);
                    entitiesAndMessages[sub.Entity].Add(messageDict);
                }

                var subDict = new Dictionary<string, object>
                {
                    { SubscriberIdCheckBox.Text, sub.Id },
                    { SubscriberNameCheckBox.Text, sub.SubscriberName },
                    { SubscriberTypeCheckBox.Text, Enum.GetName(typeof(SubscriberModel.SubscriberType), sub.Type) },
                    { SubscriberAttributeFilterCheckBox.Text, sub.AttributeFilter },
                    { SubscriberEntityCheckBox.Text, sub.Entity },
                    { SubscriberMessageCheckBox.Text, sub.Message.Id }
                };

                subscribers.Add(sub.Id, subDict);
                ((List<object>)messages[sub.Message.Id]["Subscribers"]).Add(subDict);
                entitiesAndSubscribers[sub.Entity].Add(subDict);
            }
        }

        private void BuildOutput()
        {
            if (!JsonToggle.Enabled)
            {
                if (EntityCheckBox.Checked && MessageCheckBox.Checked)
                {
                    ExportDataTextArea.Text = JsonConvert.SerializeObject(entitiesAndMessages, Formatting.Indented);
                }
                else if (EntityCheckBox.Checked)
                {
                    ExportDataTextArea.Text = JsonConvert.SerializeObject(entitiesAndSubscribers, Formatting.Indented);
                }
                else if (MessageCheckBox.Checked)
                {
                    ExportDataTextArea.Text = JsonConvert.SerializeObject(messages.Values, Formatting.Indented);
                }
                else
                {
                    ExportDataTextArea.Text = JsonConvert.SerializeObject(subscribers.Values, Formatting.Indented);
                }
            }
            else
            {
                var data = string.Empty;
                if (CsvHeadersCheckBox.Checked)
                {
                    if (SubscriberIdCheckBox.Checked)
                    {
                        data += ($"{SubscriberIdCheckBox.Text}{separator}");
                    }
                    if (SubscriberNameCheckBox.Checked)
                    {
                        data += ($"{SubscriberNameCheckBox.Text}{separator}");
                    }
                    if (SubscriberTypeCheckBox.Checked)
                    {
                        data += ($"{SubscriberTypeCheckBox.Text}{separator}");
                    }
                    if (SubscriberAttributeFilterCheckBox.Checked)
                    {
                        data += ($"{SubscriberAttributeFilterCheckBox.Text}{separator}");
                    }
                    if (SubscriberEntityCheckBox.Checked)
                    {
                        data += ($"{SubscriberEntityCheckBox.Text}{separator}");
                    }
                    if (SubscriberMessageCheckBox.Checked)
                    {
                        data += ($"{SubscriberMessageCheckBox.Text}");
                    }

                    data.TrimEnd(';');
                    data += Environment.NewLine;
                }

                foreach (var s in subscribers.Values)
                {
                    if (s.ContainsKey(SubscriberIdCheckBox.Text))
                    {
                        data += $"{s[SubscriberIdCheckBox.Text]}{separator}";
                    }
                    if (s.ContainsKey(SubscriberNameCheckBox.Text))
                    {
                        data += $"{s[SubscriberNameCheckBox.Text]}{separator}";
                    }
                    if (s.ContainsKey(SubscriberTypeCheckBox.Text))
                    {
                        data += $"{s[SubscriberTypeCheckBox.Text]}{separator}";
                    }
                    if (s.ContainsKey(SubscriberAttributeFilterCheckBox.Text) && s[SubscriberAttributeFilterCheckBox.Text] != null)
                    {
                        var attributes = new List<string>((List<string>)s[SubscriberAttributeFilterCheckBox.Text]);
                        data += $"{string.Join(attributeSeparator, attributes)}{separator}";
                    }
                    if (s.ContainsKey(SubscriberEntityCheckBox.Text))
                    {
                        data += $"{s[SubscriberEntityCheckBox.Text]}{separator}";
                    }
                    if (s.ContainsKey(SubscriberMessageCheckBox.Text))
                    {
                        data += $"{s[SubscriberMessageCheckBox.Text]}";
                    }
                    data.TrimEnd(';');
                    data += Environment.NewLine;
                }

                ExportDataTextArea.Text = data;
            }
        }

        private void SubscriberIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubscriberIdCheckBox.Checked)
            {
                foreach (var s in subscribers)
                {
                    s.Value.Add(SubscriberIdCheckBox.Text, s.Key);
                }
            }
            else
            {
                foreach (var s in subscribers)
                {
                    s.Value.Remove(SubscriberIdCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void SubscriberNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubscriberNameCheckBox.Checked)
            {
                foreach (var s in subscribers)
                {
                    s.Value.Add(SubscriberNameCheckBox.Text, data.First(sub => sub.Id == s.Key).SubscriberName);
                }
            }
            else
            {
                foreach (var s in subscribers)
                {
                    s.Value.Remove(SubscriberNameCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void SubscriberTypeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubscriberTypeCheckBox.Checked)
            {
                foreach (var s in subscribers)
                {
                    s.Value.Add(
                        SubscriberTypeCheckBox.Text, 
                        Enum.GetName(
                            typeof(SubscriberModel.SubscriberType), 
                            data.First(sub => sub.Id == s.Key).Type
                        ));
                }
            }
            else
            {
                foreach (var s in subscribers)
                {
                    s.Value.Remove(SubscriberTypeCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void SubscriberAttributeFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubscriberAttributeFilterCheckBox.Checked)
            {
                foreach (var s in subscribers)
                {
                    s.Value.Add(SubscriberAttributeFilterCheckBox.Text, data.First(sub => sub.Id == s.Key).AttributeFilter);
                }
            }
            else
            {
                foreach (var s in subscribers)
                {
                    s.Value.Remove(SubscriberAttributeFilterCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void SubscriberEntityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubscriberEntityCheckBox.Checked)
            {
                foreach (var s in subscribers)
                {
                    s.Value.Add(SubscriberEntityCheckBox.Text, data.First(sub => sub.Id == s.Key).Entity);
                }
            }
            else
            {
                foreach (var s in subscribers)
                {
                    s.Value.Remove(SubscriberEntityCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void SubscriberMessageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SubscriberMessageCheckBox.Checked)
            {
                foreach (var s in subscribers)
                {
                    s.Value.Add(SubscriberMessageCheckBox.Text, data.First(sub => sub.Id == s.Key).Message.Id);
                }
            }
            else
            {
                foreach (var s in subscribers)
                {
                    s.Value.Remove(SubscriberMessageCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void MessageIdCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageIdCheckBox.Checked)
            {
                foreach (var m in messages)
                {
                    m.Value.Add(MessageIdCheckBox.Text, data.First(sub => sub.Message.Id == m.Key).Message.Id);
                }
            }
            else
            {
                foreach (var m in messages)
                {
                    m.Value.Remove(MessageIdCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void MessageNameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageNameCheckBox.Checked)
            {
                foreach (var m in messages)
                {
                    m.Value.Add(MessageNameCheckBox.Text, data.First(sub => sub.Message.Id == m.Key).Message.MessageName);
                }
            }
            else
            {
                foreach (var m in messages)
                {
                    m.Value.Remove(MessageNameCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void MessageEntityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MessageEntityCheckBox.Checked)
            {
                foreach (var m in messages)
                {
                    m.Value.Add(MessageEntityCheckBox.Text, data.First(sub => sub.Message.Id == m.Key).Message.Entity);
                }
            }
            else
            {
                foreach (var m in messages)
                {
                    m.Value.Remove(MessageEntityCheckBox.Text);
                }
            }
            BuildOutput();
        }

        private void EntityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BuildOutput();
        }

        private void MessageCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BuildOutput();
        }

        private void JsonCsvToggle_CheckedChanged(object sender, EventArgs e)
        {
            var isJson = sender == JsonToggle;
            if (isJson)
            {
                JsonToggle.BackColor = System.Drawing.Color.Lime;
                CsvToggle.BackColor = System.Drawing.SystemColors.Control;
            }
            else
            {
                JsonToggle.BackColor = System.Drawing.SystemColors.Control;
                CsvToggle.BackColor = System.Drawing.Color.Lime;
            }

            JsonToggle.Enabled = !isJson;
            JsonMessagePanel.Visible = isJson;
            CsvToggle.Enabled = isJson;
            SeparatorPanel.Visible = !isJson;

            EntityCheckBox.Visible = isJson;
            MessageCheckBox.Visible = isJson;
            CsvHeadersCheckBox.Visible = !isJson;
            //MessageNameCheckBox.Visible = isJson;
            //MessageIdCheckBox.Visible = isJson;
            //MessageEntityCheckBox.Visible = isJson;
            //MessageLabel.Visible = isJson;

            BuildOutput();
        }

        private void CsvHeadersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            BuildOutput();
        }

        private void SeparatorChange(object sender, EventArgs e)
        {
            if (!((RadioButton)sender).Checked)
            {
                return;
            }
            if (sender == TabSepButton)
            {
                separator = "\t";
                attributeSeparator = ",";
            }
            if (sender == SemiColonSepButton)
            {
                separator = ";";
                attributeSeparator = ",";
            }
            if (sender == ColonSepButton)
            {
                separator = ":";
                attributeSeparator = ",";
            }
            if (sender == CommaSepButton)
            {
                separator = ",";
                attributeSeparator = ";";
            }

            BuildOutput();
        }
    }
}

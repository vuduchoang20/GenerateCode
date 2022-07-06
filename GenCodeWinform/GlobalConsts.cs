using System;
using System.Collections.Generic;
using System.Text;

namespace GenCodeWinform
{
    public class GlobalConsts
    {
        public static List<SelectedItem> ListPropertyType = new List<SelectedItem>()
        {
            new SelectedItem("bool","Boolean"),
            new SelectedItem("byte","Byte"),
            new SelectedItem("short","Short"),
            new SelectedItem("DateTime","DateTime"),
            new SelectedItem("decimal","Decimal"),
            new SelectedItem("double","Double"),
            new SelectedItem("Guid","Guid"),
            new SelectedItem("int","Int32"),
            new SelectedItem("long","Int64"),
            new SelectedItem("string","String")
        };

        public class SelectedItem
        {
            public string Key { get; set; }
            public string Value { get; set; }
            public SelectedItem(string key, string value)
            {
                Key = key;
                Value = value;
            }
        }
    }

}

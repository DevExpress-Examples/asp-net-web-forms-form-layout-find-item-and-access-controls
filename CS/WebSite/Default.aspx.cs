using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web.ASPxEditors;
using DevExpress.Web.ASPxFormLayout;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) { }
    protected void ASPxButton1_Click(object sender, EventArgs e) {
        LayoutItemBase item = layout.FindItemByPath(pathTextBox.Text) as LayoutItemBase;
        UpdateItem(item);
    }
    private void UpdateItem(LayoutItemBase item) {
        if(item is LayoutItem)
            SetValue(item as LayoutItem);
        else
            if(item is LayoutGroupBase)
                (item as LayoutGroupBase).ForEach(IterateNestedControls);
            else {
                pathTextBox.IsValid = false;
                pathTextBox.ValidationSettings.ErrorText = "There is no available group for this path";
            }
    }
    void IterateNestedControls(LayoutItemBase item) {
        foreach(LayoutItemBase c in item.Collection) {
            if(c is LayoutGroup)
                (c as LayoutGroup).ForEach(IterateNestedControls);
            if(c is LayoutItem)
                SetValue(c as LayoutItem);
        }
    }
    static void SetValue(LayoutItem c) {
        foreach(Control control in c.LayoutItemNestedControlContainer.Controls) {
            ASPxEdit editor = control as ASPxEdit;
            if(editor != null)
                editor.Value = DateTime.Now.ToString();
        }
    }
}
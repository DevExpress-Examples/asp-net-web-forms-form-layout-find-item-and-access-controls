using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DevExpress.Web;

public partial class _Default : System.Web.UI.Page {
    protected void Page_Load(object sender, EventArgs e) { }

    protected void ASPxButton1_Click(object sender, EventArgs e) {
        LayoutItemBase baseItem = layout.FindItemOrGroupByName(ASPxComboBox1.Value.ToString()) as LayoutItemBase;
        if (baseItem != null) {
            baseItem.Caption = ASPxComboBox1.Value.ToString() + " item found!";
            if (baseItem is LayoutItem) {
                var layoutItem = (baseItem as LayoutItem);
                foreach (var control in layoutItem.Controls) {
                    ASPxEdit editor = control as ASPxEdit;
                    if (editor != null)
                        editor.Value = DateTime.Now;
                }
            }
        }

    }
}
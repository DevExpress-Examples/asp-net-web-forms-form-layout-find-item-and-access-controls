<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<%@ Register Assembly="DevExpress.Web.v14.1, Version=14.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>How to get an item using FindItemOrGroupByName method</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxFormLayout ID="layout" runat="server" Width="100%">
                <Items>
                    <dx:LayoutGroup Caption="Group0" Name="Group0">
                        <Items>
                            <dx:LayoutGroup Caption="Group1" Name="Group01">
                                <Items>
                                    <dx:LayoutItem Caption="LayoutItem011" Name="LayoutItem011">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="layoutContainer1" runat="server">
                                                <dx:ASPxTextBox ID="ASPxTextBox1" runat="server" Width="170px"></dx:ASPxTextBox>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                    <dx:LayoutItem Caption="LayoutItem012" Name="LayoutItem012">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                                                <dx:ASPxDateEdit ID="ASPxDateEdit1" runat="server" Width="170px"></dx:ASPxDateEdit>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                            <dx:LayoutGroup Caption="Group02" Name="Group02">
                                <Items>
                                    <dx:LayoutItem Caption="LayoutItem021" Name="LayoutItem021"
                                        HelpTextSettings-Position="Bottom"
                                        HelpText="This item has two inner controls, so the value should be changed in both">
                                        <LayoutItemNestedControlCollection>
                                            <dx:LayoutItemNestedControlContainer ID="layoutContainer2" runat="server">
                                                <dx:ASPxButtonEdit ID="ASPxButtonEdit1" runat="server" Width="170px"></dx:ASPxButtonEdit>
                                                <br />
                                                <dx:ASPxMemo ID="ASPxMemo" runat="server" Width="170px"></dx:ASPxMemo>
                                            </dx:LayoutItemNestedControlContainer>
                                        </LayoutItemNestedControlCollection>
                                    </dx:LayoutItem>
                                </Items>
                            </dx:LayoutGroup>
                        </Items>
                    </dx:LayoutGroup>
                </Items>
            </dx:ASPxFormLayout>


            <dx:ASPxComboBox ID="ASPxComboBox1"
                runat="server"
                ValueType="System.String"
                SelectedIndex="0">
                <Items>
                    <dx:ListEditItem Value="Group0" />
                    <dx:ListEditItem Value="Group01" />
                    <dx:ListEditItem Value="Group02" />
                    <dx:ListEditItem Value="LayoutItem011" />
                    <dx:ListEditItem Value="LayoutItem012" />
                    <dx:ListEditItem Value="LayoutItem021" />
                </Items>
            </dx:ASPxComboBox>
            <dx:ASPxButton ID="ASPxButton1" runat="server" Text="Find Item/Group" OnClick="ASPxButton1_Click" />
        </div>
    </form>
</body>
</html>

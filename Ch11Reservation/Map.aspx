<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Map" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:TreeView ID="TreeView1" runat="server" DataSourceID="SiteMapDataSource1" 
        ImageSet="Arrows">
        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" 
            HorizontalPadding="5px" NodeSpacing="0px" VerticalPadding="0px" />
        <ParentNodeStyle Font-Bold="False" />
    </asp:TreeView>
    <asp:SiteMapDataSource ID="SiteMapDataSource1" runat="server" />
</asp:Content>


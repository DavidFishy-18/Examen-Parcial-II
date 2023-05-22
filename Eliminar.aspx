<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="Examen_Parcial_II.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Eliminar Serpiente</h2>
    <p>&nbsp;&nbsp;&nbsp; Seleccionar el animal que desea eliminar&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" Width="123px">
        </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Eliminar" class ="btn btn-primary" OnClick="Button1_Click"/>
    </p>
</asp:Content>

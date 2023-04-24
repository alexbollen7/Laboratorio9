<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio9._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>INGRESO DE NOTAS</h1>
        <p class="lead">&nbsp;</p>
        <p class="lead">Nombre del alumno:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Curso:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;Nota:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" class="btn btn-warning btn-lg" Text="Registrar nota" Height="43px" Width="184px" />
        </p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Ingresar Alumno</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>

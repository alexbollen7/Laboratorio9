<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Laboratorio9._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>INGRESO DE NOTAS</h1>
        <p class="lead">&nbsp;</p>
        <p class="lead">Nombre del alumno:
            <asp:TextBox ID="TextBoxNombre" runat="server"></asp:TextBox>
        </p>
        <p class="lead">Curso:
            <asp:TextBox ID="TextBoxCurso" runat="server"></asp:TextBox>
&nbsp;Nota:<asp:TextBox ID="TextBoxNota" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" class="btn btn-warning btn-lg" Text="Registrar nota" Height="43px" OnClick="Button1_Click1" Width="184px" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" class="btn btn-primary btn-lg" Text="Ingresar Alumno" Height="46px" Width="212px" OnClick="Button2_Click" />
        </p>
    </div>

    <div class="row">
        <div class="col-md-4">
        </div>
    </div>

</asp:Content>

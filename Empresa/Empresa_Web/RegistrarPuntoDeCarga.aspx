<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="RegistrarPuntoDeCarga.aspx.cs" Inherits="Empresa_Web.RegistrarPuntoDeCarga" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container container p-1 col-sm-7">
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6 p-3 mb-1 bg-dark text-white text-center">
                <h4>Ingresar Punto de Carga</h4>
            </div>
        </div>
        <div class="row">
            <div class="col-3"></div>
            <div class="col-6">
                <label class="control-label" for="idTxt">ID del Punto de Carga</label>
                <asp:TextBox ID="idTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="idCV" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                    CssClass="text-danger" ControlToValidate="idTxt" OnServerValidate="idCV_ServerValidate"></asp:CustomValidator>
                <br />
                <label for="tipoRbl">Tipo</label>
                <asp:RadioButtonList ID="tipoRbl" runat="server" CssClass="form-control">
                    <asp:ListItem Value="1" Selected="True" Text="Eléctrico"></asp:ListItem>
                    <asp:ListItem Value="2" Text="Dual"></asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <label class="control-label" for="capacidadTxt">Capacidad Máxima de Vehículos</label>
                <asp:TextBox ID="capacidadTxt" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:CustomValidator ID="capacidadCV" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                    CssClass="text-danger" ControlToValidate="capacidadTxt" OnServerValidate="capacidadCV_ServerValidate"></asp:CustomValidator>
                <br />
                <label class="control-label" for="vidaUtilTxt">Fecha en que deber ser remplazado</label>
                <asp:TextBox ID="vidaUtilTxt" runat="server" CssClass="form-control" placeholder="dd-MM-AAAA"></asp:TextBox>
                <asp:CustomValidator ID="vidaUtilCV" runat="server" ErrorMessage="CustomValidator" ValidateEmptyText="true"
                    CssClass="text-danger" ControlToValidate="vidaUtilTxt" OnServerValidate="vidaUtilCV_ServerValidate"></asp:CustomValidator>
                <br />
                <div class="text-center">
                    <asp:Button ID="RegistrarBtn" runat="server" Text="Registrar Estación" CssClass="btn btn-dark" OnClick="RegistrarBtn_Click" />
                </div>
            </div>
        </div>

    </div>
</asp:Content>

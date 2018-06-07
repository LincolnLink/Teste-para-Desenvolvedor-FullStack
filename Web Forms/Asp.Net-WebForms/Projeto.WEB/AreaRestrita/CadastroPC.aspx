<%@ Page Title="" Language="C#" MasterPageFile="~/AreaRestrita/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="CadastroPC.aspx.cs" Inherits="Projeto.WEB.AreaRestrita.CadastroPC" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Cadastro de Computadores</h4>
    <hr />

    <div class="row">
         <div class="col-md-6">
         <label>Marca do PC:</label>
         <asp:TextBox ID="txtMarca" runat="server"
         CssClass="form-control" />
         <br />
         <label>Modelo :</label>
         <asp:TextBox ID="txtModelo" runat="server"
         CssClass="form-control" />
         <br />
         <label>Placa mae:</label>
         <asp:TextBox ID="txtPmae" runat="server"
         CssClass="form-control" />
         <br />

         <label>Memoria ram:</label>
         <asp:TextBox ID="txtRam" runat="server"
         CssClass="form-control" />
         <br />

         <label>HD:</label>
         <asp:TextBox ID="txtHd" runat="server"
         CssClass="form-control" />
         <br />
         
         <label> Marca do HD:</label>
         <asp:TextBox ID="txtmhd" runat="server"
         CssClass="form-control" />
         <br />

             
         <label>Velocidade do processador:</label>
         <asp:TextBox ID="txtVp" runat="server"
         CssClass="form-control" />
         <br />

         <label>Envie sua foto:</label>
         <asp:FileUpload ID="txtFoto" runat="server" CssClass="form-control" />
            <br />


         
         <br />
         <br />
         <asp:Button ID="btnCadastro" runat="server"
         Text="Cadastrar computador" CssClass="btn btn-success" OnClick="btnCadastro_Click" />
         <br />
         <br />
         <asp:Label ID="lblMensagem" runat="server" />
         </div>
    </div>
</asp:Content>

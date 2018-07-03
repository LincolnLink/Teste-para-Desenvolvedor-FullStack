<%@ Page Title="" Language="C#" MasterPageFile="~/AreaRestrita/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="EdicaoPC.aspx.cs" Inherits="Projeto.WEB.AreaRestrita.EdicaoPC" %>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h4>Cadastro de Computadores</h4>
    <hr />

    <div class="row">
         <div class="col-md-6">

         <asp:Image ID="imgUsuario" runat="server" Width="100" Height="50" CssClass="img-circle" />
             
         <label>Marca do PC:</label>
         <asp:TextBox ID="txtId" runat="server"
         CssClass="form-control" ReadOnly="true" />
         <br />

         <label>Marca do PC:</label>
         <asp:TextBox ID="txtMarca" runat="server"
         CssClass="form-control" />
         <asp:RequiredFieldValidator 
            ID="RequiredNome" 
            runat="server"
            ControlToValidate="txtMarca"
            ErrorMessage="Por favor, informe a marca do PC"
            ForeColor="Red"
            Display="Dynamic"
            ValidationGroup="formularioCadastro" 
         />
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
         Text="Cadastrar computador" CssClass="btn btn-success"
             OnClick="BtnCadastro_Click"  ValidationGroup="formularioCadastro" />
         <br />
         <br />

         <asp:Label ID="lblMensagem" runat="server" />
         </div>
    </div>
</asp:Content>

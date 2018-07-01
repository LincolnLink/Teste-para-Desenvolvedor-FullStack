<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Projeto.WEB.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>BlueOpex</title>


    <!-- folhas de estilo CSS -->
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <link href="Content/bootstrap-grid.min.css" rel="stylesheet" />

    <!-- Arquivos javascript --> 
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

</head>
<body class="container">
    <form id="form1" runat="server">
        <div>
            <div class="row">
                <div class="col-md-6 col-md-offset-6">
                    <div class="panel panel-primary">
                        <div class="panel-heading">
                            <h4>BlueOpex</h4>
                        </div>
                        <div class="panel-body">
                                Para acessar o sistema, informe seus dados abaixo:
                            <hr />
                            <label>Login de Acesso:</label>
                            <asp:TextBox ID="txtLogin" runat="server" CssClass="form-control" />
                            <br />
                            <label>Senha de Acesso:</label>
                            <asp:TextBox ID="txtSenha" runat="server" CssClass="form-control" TextMode="Password" />
                        </div>

                        <div class="panel-footer">
                            <br />
                            <asp:Button ID="btnAcesso" runat="server" Text="Acessar Sistema" CssClass="btn btn-primary" 
                                 OnClick="BtnAcesso_Click" />
                            <hr />
                            <br />  
                            
                            <asp:Label ID="lblMensagem" runat="server"></asp:Label>
                            <br />  
                                Não possui conta?
                            <a href="#" data-target="#janela" data-toggle="modal">
                                Cadastre-se aqui
                            </a>
                        </div>

                    </div>
                </div>
            </div>

            <div id="janela" class="modal fade">
                <div class="modal-dialog">
                    <div class="modal-content">
                        <div class="modal-header bg-primary">
                            <h3>Criar Conta de Usuário</h3>
                        </div>
                        <div class="modal-body">
                            <div class="row">
                                <div class="col-md-12">
                                    <label>Nome do Usuário:</label>
                                    <asp:TextBox ID="txtNome" runat="server" CssClass="form-control" />
                                    <asp:RequiredFieldValidator ID="requiredNome" runat="server"
                                    ControlToValidate="txtNome" ErrorMessage="Por favor, informe o nome do usuário" 
                                    ForeColor="Red" Display="Dynamic"  ValidationGroup="formularioCadastro"
                                     />
                                    <asp:RegularExpressionValidator ID="regexNome" runat="server" ControlToValidate="txtNome"
                                        ErrorMessage="Somente letras,de 6 a 50 caracteres." ForeColor="Red" Display="Dynamic" 
                                        ValidationGroup="formularioCadastro" ValidationExpression="^[A-Za-zÀ-Üà-ü\s]{6,50}$" />                                 
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-12">
                                    <label>Login de Acesso:</label>
                                    <asp:TextBox ID="txtLoginAcesso" runat="server" CssClass="form-control" />
                                    <asp:RequiredFieldValidator ID="requiredLoginAcesso" runat="server" 
                                        ControlToValidate="txtLoginAcesso" ErrorMessage="Por favor, informe o login do usuário"
                                        ForeColor="Red" Display="Dynamic" ValidationGroup="formularioCadastro" /> 
                                     <asp:RegularExpressionValidator ID="regexLogin" runat="server" ControlToValidate="txtLoginAcesso" 
                                    ErrorMessage="Somente letras minúsculas ou numéros, de 6 a 20 caracteres." ForeColor="Red" 
                                    Display="Dynamic" ValidationGroup="formularioCadastro" ValidationExpression="^[a-z0-9]{6,20}$" />
                                </div>
                               
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <label>Informe sua Senha:</label>
                                    <asp:TextBox ID="txtSenhaAcesso" runat="server" CssClass="form-control" TextMode="Password" />

                                    <asp:RequiredFieldValidator ID="requiredSenhaAcesso" runat="server" ControlToValidate="txtSenhaAcesso" 
                                        ErrorMessage="Por favor, informe a senha do usuário" ForeColor="Red" 
                                        Display="Dynamic" ValidationGroup="formularioCadastro" />
                                    
                                    <asp:RegularExpressionValidator ID="regexSenha" runat="server" 
                                        ErrorMessage="Senha inválida. Sua senha deve conter no minimo 3 e no máximo 25 digitos, sendo no minimo uma letra minuscula, uma letra maiuscula, um número e um caracter especial (#*.@)."
                                        Display="Dynamic" ControlToValidate="txtSenhaAcesso" 
                                        ValidationExpression="^.*(?=.{3,25}).*$" 
                                        ForeColor="Red" ValidationGroup="formularioCadastro" />
                                        
                                </div>
                                <div class="col-md-6">
                                    <label>Confirme sua Senha:</label>
                                    <asp:TextBox ID="txtSenhaConfirm" runat="server" CssClass="form-control" TextMode="Password" />

                                    <asp:RequiredFieldValidator  ID="requiredSenhaConfirm" runat="server" ControlToValidate="txtSenhaConfirm"
                                        ErrorMessage="Por favor, confirme a senha do usuário" ForeColor="Red" Display="Dynamic" ValidationGroup="formularioCadastro" />

                                    <asp:CompareValidator ID="compareSenha" runat="server" ControlToValidate="txtSenhaConfirm"
                                        ControlToCompare="txtSenhaAcesso" ErrorMessage="Senhas não conferem"
                                        ForeColor="Red" Display="Dynamic" ValidationGroup="formularioCadastro" />                                   
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-12">
                                    <label>Nome da Empresa:</label>
                                    <asp:TextBox ID="txtEmpresa" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                            <br />                           
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="btnCadastro" runat="server" Text="Criar Conta de Usuário"
                                CssClass="btn btn-success" OnClick="BtnCadastro_Click" ValidationGroup="formularioCadastro" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

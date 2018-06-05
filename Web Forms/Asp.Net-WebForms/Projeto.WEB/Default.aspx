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
                            <asp:Button ID="btnAcesso" runat="server" Text="Acessar Sistema" CssClass="btn btn-primary" />
                            <hr />
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
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-12">
                                    <label>Login de Acesso:</label>
                                    <asp:TextBox ID="txtLoginAcesso" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-6">
                                    <label>Informe sua Senha:</label>
                                    <asp:TextBox ID="txtSenhaAcesso" runat="server" CssClass="form-control" TextMode="Password" />
                                </div>
                                <div class="col-md-6">
                                    <label>Confirme sua Senha:</label>
                                    <asp:TextBox ID="txtSenhaConfirm" runat="server" CssClass="form-control" TextMode="Password" />
                                </div>
                            </div>
                            <br />
                            <div class="row">
                                <div class="col-md-12">
                                    <label>Envie sua foto:</label>
                                    <asp:FileUpload ID="txtFoto" runat="server" CssClass="form-control" />
                                </div>
                            </div>
                        </div>
                        <div class="modal-footer">
                            <asp:Button ID="btnCadastro" runat="server" Text="Criar Conta de Usuário" CssClass="btn btn-success" />
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>

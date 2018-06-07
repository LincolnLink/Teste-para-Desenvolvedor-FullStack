﻿<%@ Page Title="" Language="C#" MasterPageFile="~/AreaRestrita/Templates/Layout.Master" AutoEventWireup="true" CodeBehind="ConsultaPC.aspx.cs" Inherits="Projeto.WEB.AreaRestrita.ConsultaPC" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h4>Consulta de Computador</h4>
    <hr />    <div class="row">
        <div class="col-md-4">
            <!--<label>Empresa:</label>
            <asp:TextBox ID="txtEmpresa" runat="server"
            CssClass="form-control" type="date" />
            <br />-->

            <asp:Button ID="btnConsulta" runat="server"
            CssClass="btn btn-primary" Text="Pesquisar Computador" OnClick="BtnConsulta_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensagem" runat="server" />
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:GridView ID="gridPc" runat="server"
            CssClass="table table-hover" >

                <EmptyDataTemplate>
                Nenhuma tarefa foi encontrada
                </EmptyDataTemplate>
                <Columns>
                     <asp:TemplateField HeaderText="ID">
                        <ItemTemplate>
                        <%# Eval("IdComputador ") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Marca">
                        <ItemTemplate>
                        <%# Eval("Marca ") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Modelo">
                        <ItemTemplate>
                        <%# Eval("Modelo") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Placa mãe">
                        <ItemTemplate>
                        <%# Eval("PlacaMae") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Memória RAM">
                        <ItemTemplate>
                        <%# Eval("MemoriaRAM") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="HD Armazenamento">
                        <ItemTemplate>
                        <%# Eval("HdArmazenamento ") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Marca do HD">
                        <ItemTemplate>
                        <%# Eval("HdMarco ") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Velocidade do Processador">
                        <ItemTemplate>
                        <%# Eval("VelocidadeProcessador ") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                   
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>

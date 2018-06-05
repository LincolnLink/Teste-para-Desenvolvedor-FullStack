create table Usuario(
	IdUsuario integer identity(1,1),
	Nome nvarchar(50) not null,
	[Login] nvarchar(25) not null unique,
	Senha nvarchar(50) not null,
	Empresa nvarchar(50) not null,
primary key(IdUsuario))
go


 <div class="row">
                                <div class="col-md-12">
                                    <label>Envie sua foto:</label>
                                    <asp:FileUpload ID="txtFoto" runat="server" CssClass="form-control" />
                                </div>
                            </div>
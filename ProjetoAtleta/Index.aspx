<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="ProjetoAtleta.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Projeto Atleta</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="lbl_Error" runat="server" Visible="False" ForeColor="Red" />

            <br />
            <br />

            <asp:Label ID="lbl_Name" runat="server" Text="Nome:" />
            <br />
            <asp:TextBox ID="txt_Nome" runat="server" Width="120px"/>
            
            <br />
            <br />

            <asp:Label ID="lbl_Peso" runat="server" Text="Peso: (Kg)" />
            <br />
            <asp:TextBox ID="txt_Peso" runat="server" Width="120px"/>
            
            <br />
            <br />

            <asp:Label ID="lbl_Altura" runat="server" Text="Altura: (M)" />
            <br />
            <asp:TextBox ID="txt_Altura" runat="server" Width="120px"/>
            
            <br />
            <br />

            <asp:Label ID="lbl_Idade" runat="server" Text="Idade:" />
            <br />
            <asp:TextBox ID="txt_Idade" runat="server" Width="120px"/>
            
            <br />
            <br />
            
            <asp:Button ID="btn_Calc" runat="server" Text="Calcular IMC" Width="120px" OnClick="btn_Calc_Click" />
            <br />
            <br />
            <asp:Label ID="lbl_Resultado" runat="server" Text="" Visible="false"/>
       </div>
    </form>
</body>
</html>

<%@ Page Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="aboutTitle" ContentPlaceHolderID="TitleContent" runat="server">
    About Us
</asp:Content>

<asp:Content ID="aboutContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>About</h2>
    <p>
        This is practice of git source control, so I'm just making some irrelevant changes.

        <div>
    
        <% using (Html.BeginForm())
            { %>
    
    
            <label for="UserName">User Name:</label>
            <br />
            <%= Html.TextBox("UserName") %>
        
            <br /><br />
            
            <label for="Password">Password:</label>
            <br />
            <%= Html.Password("Password") %>
        
            <br /><br />

            <input type="submit" value="Log in" />        
    
        <% } %>
    
    </div>

    </p>
</asp:Content>

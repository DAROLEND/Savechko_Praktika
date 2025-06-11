<%@ Page Title="Home" Language="C#" MasterPageFile="~/Site1.master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="masterpage.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        h2 {
            color: #247BA0;
        }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Home page</h2>
    <p>Вітаємо на головній сторінці вашого сайту ASP.NET Web Forms!</p>
</asp:Content>

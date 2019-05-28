<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Default.HeroArea" CodeBehind="HeroArea.ascx.cs" %>


<div class="hero-area" data-control-id="<%= ControlId %>" data-control-order="<%= ControlOrder %>">
    <div class="hero-area__title">
        <%= ContentArea.Title %>
    </div>
    <div class="hero-area__text">
        <%= ContentArea.Text %>
    </div>
</div>
    
<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Default.FeaturedProducts" CodeBehind="FeaturedProducts.ascx.cs" %>


<% if(HasProducts) { %>
<div class="featured-products" id="FeaturedProductsComponent" data-control-id="<%= ControlId %>" data-control-order="<%= ControlOrder %>">
    <div class="featured-products__header">
        Featured parts and accessories
    </div>
    <ul class="featured-products__list">
        <asp:PlaceHolder id="ProductCardPlaceholder" runat="server" />
    </ul>
</div>
<% } %>
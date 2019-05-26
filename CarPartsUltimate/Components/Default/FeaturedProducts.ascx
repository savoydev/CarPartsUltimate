<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Default.FeaturedProducts" CodeBehind="FeaturedProducts.ascx.cs" %>


<div class="featured-products" id="FeaturedProductsComponent" runat="server">
    <div class="featured-products__header">
        Featured parts and accessories
    </div>
    <ul class="featured-products__list">
        <asp:PlaceHolder id="ProductCardPlaceholder" runat="server" />
    </ul>
</div>
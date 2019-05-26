<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Universal.ProductCard" %>


<li class="featured-product">
    <img src="<%= GetFirstImage(Product) %>" class="featured-product__image" />
    <div class="featured-product__name">
    <%= Product.Title %>
    </div>
    <div class="featured-product__price">
    <%= Product.Price %>
    </div>
    <a href="" class="featured-product__link button button_type_primary">
    <%= Product.StockCode %>
    </a>
</li>
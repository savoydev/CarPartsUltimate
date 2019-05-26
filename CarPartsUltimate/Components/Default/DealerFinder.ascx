<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Default.DealerFinder" CodeBehind="DealerFinder.ascx.cs" %>

<div class="nearest-dealer-finder">
    <div class="nearest-dealer-header">
        Your Nearest Dealers
    </div>
    
    <ul class="nearest-dealers">
        <% foreach(var dealer in Dealerships) { %>
        <li class="nearest-dealer">
            <div class="nearest-dealer__info">
                <div class="nearest-dealer__name">
                    <%= dealer.Name %>
                </div>
                <div class="nearest-dealer__distance">
                    Distance: 3.89mi
                </div>
            </div>
            <a class="nearest-dealer__button button button_type_primary" 
               href="<%= %>">
                Shop Now
            </a>
        </li>
        <% } %>
    </ul>
</div>

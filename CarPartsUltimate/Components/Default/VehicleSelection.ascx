<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Default.VehicleSelection" CodeBehind="VehicleSelection.ascx.cs" %>


<div class="refine-fitment" data-control-id="<%= ControlId %>" data-control-order="<%= ControlOrder %>">
    <div class="refine-fitment__header">
        Select a vehicle type
    </div>
    <ul class="refine-fitment-links">
        <% foreach(var refineLink in RefineLinks) { %>
        <li>
            <a href="#" class="refine-fitment-link">
                <img src="<%= refineLink.Image.ThumbnailSource %>" class="refine-fitment-link__image" />
                <div class="refine-fitment-link__name">
                    <%= refineLink.Name %>
                </div>
            </a>
        </li>
        <% } %>
    </ul>
</div>
            
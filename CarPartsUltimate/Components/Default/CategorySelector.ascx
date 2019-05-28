<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Default.CategorySelector" CodeBehind="CategorySelector.ascx.cs" %>

<div class="quick-start" data-control-id="<%= ControlId %>" data-control-order="<%= ControlOrder %>">
    <div class="quick-start__header">
        Select a category
    </div>
    <ul class="quick-start__list">
        <% foreach(var category in Categories) { %>
        <li class="quick-start__category">
            <a href="<%= category.DestinationHref %>" class="quick-start__category-link">
                <img src="<%= category.Image.ThumbnailSource %>" class="quick-start__category-image" />
                <div class="quick-start__category-name">
                    <%= category.Name %>
                </div>
            </a>
        </li>
        <% } %>
    </ul>
</div>
            
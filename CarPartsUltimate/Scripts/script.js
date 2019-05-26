(function partsHeaderLinkEvent() {
    var partsHeaderLinks = document.querySelectorAll('[data-id="parts-header"]');
    if (partsHeaderLinks.length > 0) {
        for (let i = 0; i < partsHeaderLinks.length; i++) {
            partsHeaderLinks[i].addEventListener('click', ToggleCategoryDisplay);
        }
    }
})();


/*(function vehiclesHeaderLinkEvent() {
    var vehiclesHeaderLinks = document.querySelectorAll('[data-id="vehicles-header"]');
    if (vehiclesHeaderLinks.length > 0) {
        for (let i = 0; i < vehiclesHeaderLinks.length; i++) {
            vehiclesHeaderLinks[i].addEventListener('click', ToggleVehicleSelectionModalDisplay);
        }
    }
})();*/



function ToggleCategoryDisplay() {
    if(CategoriesLoaded())
    {
        ToggleDisplay('HeaderDropdown')
    }
    else {
        GetPartsCategories();
    }
}

function ToggleDisplay(elementId) {
    if(document.getElementById(elementId).style.display != 'none')
    {
        document.getElementById(elementId).style.display = 'none';
    }
    else {
        document.getElementById(elementId).style.display = 'block'
    }
}

function CategoriesLoaded() {
    if(document.getElementById('HeaderDropdown') != null)
    {
        return true;
    }       
    else {
        return false;
    }
}

function GetPartsCategories() {
    var xhttp = new XMLHttpRequest();
    xhttp.onreadystatechange = function() {
        if (this.readyState == 4 && this.status == 200) {
            // Typical action to be performed when the document is ready:
            InsertCategories(JSON.parse(xhttp.responseText));
        }
    };
    xhttp.open("GET", "/api/Categories", true);
    xhttp.send();  
}

function InsertCategories(categories) {
    document.getElementById('HeaderParts').
        appendChild(AddLinks(categories, ConstructHeaderDropdownDiv()));
}

function ConstructHeaderDropdownDiv() {
    let div = document.createElement('div');
    div.className = 'header-dropdown';
    div.id = 'HeaderDropdown';
    return div;
}

function ConstructHeaderDropdownLink(category) {
    let a = document.createElement('a');
    a.className = 'header-dropdown__link';
    a.href = category.DestinationHref;
    a.innerText = category.Name;
    return a;
}

function AddLinks(categories, div) {
    for (let i = 0; i < categories.length; i++) {
        div.appendChild(ConstructHeaderDropdownLink(categories[i]));
    }
    return div;
}
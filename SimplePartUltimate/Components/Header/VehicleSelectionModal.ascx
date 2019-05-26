<%@ Control Language="C#" Inherits="CarPartsUltimate.Components.Header.VehicleSelectionModal" %>


<div class="vehicle-selection-modal" 
     id="VehicleSelectionModal"
     v-show="vehicleOptions.length > 0">
    <div class="vehicle-selection-modal__header">
        Select Your Vehicle
    </div>
    <div class="vehicle-selection-modal__content" 
         id="VehicleSelectionModalContent"
         v-if="vehicleOptions != null">
            <div v-for="vehicleOption in vehicleOptions" 
                 class="vehicle-selection-modal__link">
                <img v-bind:src="vehicleOption.Image.ThumbnailSource" class="vehicle-selection-modal__image" />
                <div class="vehicle-selection-modal__text">
                    {{ vehicleOption.Name }}
                </div>
        </div>
    </div>
</div>
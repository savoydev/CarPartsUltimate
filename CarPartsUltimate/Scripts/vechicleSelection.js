var vehicleSelection = new Vue({
  el: "#app",
  data: {
    vehicleOptions: []
  },
  created() {},
  computed: {},
  methods: {
    async GetVehicles() {
      return new Promise(function(resolve, reject) {
        var xhttp = new XMLHttpRequest();
        xhttp.onreadystatechange = function() {
          if (this.readyState == 4 && this.status == 200) {
            resolve(JSON.parse(xhttp.responseText));
          }
        };
        xhttp.open("GET", "/api/Fitment", true);
        xhttp.send();
      });
    },
    async ToggleVehicleSelectionModalDisplay() {
      this.SetModalTop();
      if (this.VehiclesLoaded()) {
        this.ToggleDisplay("VehicleSelectionModal");
      } else {
        this.vehicleOptions = await this.GetVehicles();
      }
    },
    SetModalTop() {
      document.getElementById("VehicleSelectionModal").style.top =
        document.getElementById("MainNav").offsetHeight + "px";
    },
    VehiclesLoaded() {
      let modalContentDiv = document.getElementById(
        "VehicleSelectionModalContent"
      );
      if (modalContentDiv == null) {
        return false;
      } else if (
        document.getElementById("VehicleSelectionModalContent").children
          .length > 0
      ) {
        return true;
      } else {
        return false;
      }
    },
    ToggleDisplay(elementId) {
      if (document.getElementById(elementId).style.display != "none") {
        document.getElementById(elementId).style.display = "none";
      } else {
        document.getElementById(elementId).style.display = "block";
      }
    }
  }
});

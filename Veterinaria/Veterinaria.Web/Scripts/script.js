// Initialize and add the map
function initMap() {
    // The location
    var itt = { lat: 32.529134, lng: -116.986848 };
    // The map, centered
    var map = new google.maps.Map(
        document.getElementById('map'), { zoom: 4, center: itt });
    // The marker, positioned at Uluru
    var marker = new google.maps.Marker({ position: itt, map: map });
}
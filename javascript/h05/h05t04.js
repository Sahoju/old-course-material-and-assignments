/* Houses- JavaScript */
$(document).ready(function(){
    // use ajax() to load h04t04-ajax-json-talot.json file
    // call showHouses from done()-function
    $.ajax({
        url: 'h05t04.json',
        cache: false
    }).done(function(data) {
        console.log("success");
        showHouses(data);
    }).fail(function() {
        console.log("But how? The file is in the same directory as this!");
    });
});

// function shows houses information
function showHouses(data) {
    // loop through all houses data 
    $.each(data.houses, function(index, house) {
        
        // create a div element and add "houseContainer" class to it
        var div = $('<div class="houseContainer"></div>');
        // create img element and use "houseImage" class to it and src to house image
        var image = $('<img class="houseImage" src="img/' + house.image + '" />');
        // create p element, use address as a text and "header" class
        var header = $('<p class="header">' + house.address + '</p>');
        // create p element ja use house size as a text
        var size = $('<p>' + house.size + '</p>');
        // create p element and use house text as a text and "text" class
        var text = $('<p>' + house.text + '</p>');
        // create p element and use house price as a text
        var price = $('<p>' + house.price + '</p>');
        //  add all elements to houseDiv lisätään kaikki luodut elementit taloDiv-elementtiin
        div.append(image,header,size,text,price);
        // add div to #houses in DOM
        $("#houses").append(div);
    });
}

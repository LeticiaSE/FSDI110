
function fetchCatalog() {
    $.ajax({
        type: 'GET',
        url: '/catalog/allProperties',
        success: res => {
            console.log(res);
            for(let i=0; i < res.length; i++){
                displayProperty(res[i]);
            }
        },
        error: details => {
            console.log("error", details);
        }
    });
}

function displayProperty(property){
    //create the syntax
    var syntax =
    `<div class = 'item'>
        <h5 class = 'title'>${property.title}</h5>
    </div>`

    //get container
    var container = $("#catalog-container");
    
    //append sintax to container
    container.append(syntax);
}

function init() {
    console.log("catalog page.!");

    fetchCatalog();
}

window.onload = init;
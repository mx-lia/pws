let apiCall = (value) => {
    switch (value) {
        case "GET": {
            fetch("http://localhost:60902/.mys")
                .then((response) => response.json())
                .then((data) => {
                    document.getElementById("output").innerHTML = JSON.stringify(data);
                });
        } break;
        case "POST": {
            let param = document.getElementById("input").value;
            fetch(`http://localhost:60902/.mys?result=${param}`, { method: "POST" });
        } break;
        case "PUT": {
            let param = document.getElementById("input").value;
            fetch(`http://localhost:60902/.mys?add=${param}`, { method: "PUT" });
        } break;
        case "DELETE": {
            fetch("http://localhost:60902/.mys", { method: "DELETE" });
        } break;
    }
}
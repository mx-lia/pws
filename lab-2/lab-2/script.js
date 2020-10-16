$("#getBtn").click(function () {
    $.ajax({
        url: "http://localhost:50766/api/webapi",
        success: function (data) {
            $("#output").html(data);
        }
    });
});

$("#postBtn").click(function () {
    let param = $("#input").val();
    $.ajax({
        url: `http://localhost:50766/api/webapi?result=${param}`,
        method: "POST"
    });
});

$("#putBtn").click(function () {
    let param = $("#input").val();
    $.ajax({
        url: `http://localhost:50766/api/webapi?add=${param}`,
        method: "PUT"
    });
});

$("#deleteBtn").click(function () {
    $.ajax({
        url: "http://localhost:50766/api/webapi",
        method: "DELETE"
    });
});
$("#buttonSearch").on("click", function () {
    $.ajax(
        {
            type: "POST",
            url: "CashFlow", "GetAllDespesas"),
        dataType: "json",
            success: function(result) {

            },
    error: function(x, e) {

    }
});
});
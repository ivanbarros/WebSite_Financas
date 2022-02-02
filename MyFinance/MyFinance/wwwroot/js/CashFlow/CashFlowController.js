debugger;
$('#buttonSearch').on("click",function () {

    if ($('#CategoryTypeId').val() == '' && $('#CashFlowTypeId').val() == '') {

        getAllDespesas();
    }
    else {
        getDespesaReceita();
    }
    
    $('#CategoryTypeId').removeData($('#CategoryTypeId').val);
    $('#CashFlowTypeId').removeData($('#CashFlowTypeId').val);
});
debugger;

function getDespesaReceita() {
    $.ajax({
        url: '/CashFlow/GetDespesaReceita',
        dataType: "json",
        type: "post",
        contenttype: 'application/json; charset=utf-8',
        data: {
            categoryName: $('#CategoryTypeId').val(),
            decision: $('#CashFlowTypeId').val()
        }
    });
}

function getAllDespesas() {
    $.ajax({
        url: '/CashFlow/GetAllDespesas',
        dataType: "json",
        type: "post",
        contenttype: 'application/json; charset=utf-8',
        data: {
            categoryName: $('#CategoryTypeId').val(),
            decision: $('#CashFlowTypeId').val()
        },
        success: function (data) {
            debugger;
            alert("sucesso"),
            $('#resultDespesaSelectedDiv').html(data);
        },
        error: function () {
            debugger;
            alert("erro")
            $('#resultDespesaSelectedDiv').html(data);
        }
    });
}
        



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
        },
        success: function (data) {
            debugger;
            
                //$('#resultDespesaSelectedDiv').html(JSON.stringify(data));
            $('#resultDespesaSelectedDiv').html(JSON.stringify(data));
        },
        error: function (data) {
            debugger;
          
            /*$('#resultDespesaSelectedDiv').html(JSON.stringify(data));*/
            $('#resultDespesaSelectedDiv').html(JSON.stringify(data));
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
                //$('#resultDespesaSelectedDiv').html(JSON.stringify(data));
                $('#resultDespesaSelectedDiv').html('<object data="https://localhost:5001/CashFlow/GetAllDespesas" width="800" height="700"/>');
        },
        error: function (data) {
            debugger;
            alert("erro")
            $('#resultDespesaSelectedDiv').html('<object data="https://localhost:5001/CashFlow/GetAllDespesas" width="auto" height="auto"/>');
        }
    });
}
        



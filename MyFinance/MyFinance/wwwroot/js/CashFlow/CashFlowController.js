debugger;
$('#buttonSearch').on("click", function () {

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
    $('#resultDespesaSelectedDiv').load("/CashFlow/GetDespesaReceita?categoryName=" + $('#CategoryTypeId').val() + "&decision=" + $('#CashFlowTypeId').val());
};
   

function getAllDespesas() {
    $('#resultDespesaSelectedDiv').load("/CashFlow/GetAllDespesas");
}
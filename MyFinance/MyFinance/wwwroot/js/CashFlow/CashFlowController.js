debugger;
$('#buttonSearch').on("click", function () {

        getDespesaReceita();


    $('#CategoryTypeId').removeData($('#CategoryTypeId').val);
    $('#CashFlowTypeId').removeData($('#CashFlowTypeId').val);
});
debugger;

function getDespesaReceita() {
    $('#resultDespesaSelectedDiv').load("/CashFlow/GetDespesaReceita?categoryName=" + $('#CategoryTypeId').val() + "&decision=" + $('#CashFlowTypeId').val());
};
   

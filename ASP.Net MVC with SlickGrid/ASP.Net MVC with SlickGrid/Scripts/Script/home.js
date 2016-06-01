var grid;
var columns = [
                        { id: "Id", name: "Id", field: "Id" },
                        { id: "Name", name: "Name", field: "Name", minWidth:70 },
                         { id: "Salary", name: "Salary", field: "Salary" },
                          { id: "Address", name: "Address", field: "Address" }

];

var options = {
    enableCellNavigation: true,
    enableColumnReorder: false,
    multiColumnSort: true,
    asyncEditorLoading: true,
    forceFitColumns: true
};

$(function () {
    var myData = [];
    $.getJSON('/Home/getEmployeeList', function (data) {
        myData = data;
        console.log(myData);
        grid = new Slick.Grid("#myGrid", myData, columns, options);
    });
});
// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
//Login button 
// Element to indecate
var button = document.querySelector("#kt_button_1");

// Handle button click event
button.addEventListener("click", function() {
    // Activate indicator
    button.setAttribute("data-kt-indicator", "on");

    // Disable indicator after 3 seconds
    setTimeout(function() {
        button.removeAttribute("data-kt-indicator");
    }, 3000);
});

// $document.querySelector("#kt_sign_in_submit"){
//     addEventListener("click", (function (n)) {
//         n.preventDefault(), 
//     };
// }



//Datatable for Employee
$(document).ready(function () {
    dataTable = $("#employeeDataTable").DataTable({
        "processing": true,
        "serverSide": true,
        "ajax": {
            "url": "/Account/EmployeeList",
            "type": "POST",
            "datatype": "json",
        },
        "columns": [
            { "data": "employeeId", "visible": false },
            { "data": "name", "autoWidth": true },
            { "data": "userName", "autoWidth": true },
            { "data": "emailAddress", "autoWidth": true },
            { "data": "phoneNumber", "autoWidth": true },
            { "data": "roleName", "autoWidth": true },
            {
                "data": "listItemId", "orderable": false, "render": function (data, type, row) {
                    var deleteUrl = "/Employee/DeleteEmployee/" + row.employeeId;
                    if (row.role.roleName != "SuperAdmin") {
                        return "<a href='/Employee/EditEmployee/" + row.employeeId + "'  class='btn btn-primary btn-sm' style='margin-left:5px' ><i class='far fa-edit'></i> Edit</a><a href='#' class='btn btn-danger btn-sm' style='margin-left:5px' onclick=deleteConfirm('" + deleteUrl + "'); ><i class='far fa-trash-alt'></i> Delete</a>";
                    } else {
                        return "<a href='/Employee/EditEmployee/" + row.employeeId + "'  class='btn btn-primary btn-sm' style='margin-left:5px' ><i class='far fa-edit'></i> Edit</a>";
                    }

                }
            },

        ],
        "language": {

            "emptyTable": "No data found, Please click on <b>Add New</b> Button"
        }
    });
});
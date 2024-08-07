﻿$(document).ready(function(){
    loadDataTable();
});


function loadDataTable() {
    dataTable = $('#tblData').DataTable({
        "ajax": { url: '/admin/product/getall' },
        "columns": [
            {data : 'title', "width":"20%"},                     
            { data: 'author', "width": "20%" },
            { data: 'isbn', "width": "10%" },
            {data: 'listPrice', "width":"5%"},
            {data : 'price', "width":"5%"},
            {data: 'price50', "width": "5%" },
            {data: 'price100', "width": "5%" },
            {data: 'category.name', "width": "5%" },
           
            {
                data: 'id',
                "render": function (data) {
                    return `<div class="w-75 btn-group" role= "group">
                       
                         <a href="/admin/product/upsert?id=${data}" class="btn btn-primary mx-2">
                            <i class="bi bi-pencil-square"></i> Edit
                         </a>
                         <a href="/admin/product/delete/${data}" class="btn btn-danger mx-2">
                            <i class="bi bi-trash3-fill"></i> Delete
                         </a>
                        </div>`
                },
                "width" : "25%"
            }
        ]
    });
}

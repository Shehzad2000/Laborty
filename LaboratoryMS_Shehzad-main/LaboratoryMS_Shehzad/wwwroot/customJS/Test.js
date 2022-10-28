$(document).ready(function () {
    LoadCategoryData();
    LoadUnitData();
    LoadTestData();
});
function LoadCategoryData() {
    $.ajax({
        url:,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        dataType: "JSON",
        success: function (res) {
            var html = '';
            html += '<select id="ddl_Category" class="form-control">';
            $.each(res, function (key, item) {
                html += '<option value="' + item.CatID + '">' + item.CategoryName + '</option>';
            })
            html += '</select>';
            $('.Category').html(html);
        },
        error: function (err) {
            alert(err.responseText);
        }
    })
}
function LoadUnitData() {
    $.ajax({
        url:,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        dataType: "JSON",
        success: function (res) {
            var html = '';
            html += '<select id="ddl_Unit" class="form-control">';
            $.each(res, function (key, item) {
                html += '<option value="' + item.UnitID + '">' + item.UnitName + '</option>';
            })
            html += '</select>';
            $('.Unit').html(html);
        },
        error: function (err) {
            alert(err.responseText);
        }
    })
}
function LoadTestData() {
    $.ajax({
        url:,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        dataType: "JSON",
        success: function (res) {
            var html = '';
            $.each(res, function (key, item) {
                html += '<tr>';
                html += '<td>' + (Sno + 1) + '</td>';
                html += '<td>' + item.TestName + '</td>';
                html += '<td>' + item.CategoryName + '</td>';
                html += '<td>' + item.UnitName + '</td>';
                html += '<td>' + item.NormalRange + '</td>';
                html += '<td>' + item.PatientName + '</td>';
                html += '<td>' + item.DoctorName + '</td>';
                html += '<td>' + item.Contact + '</td>';
                html += '<td>' + item.Gender + '</td>';
                html += '<td>' + item.TestDate + '</td>';
                html += '<tr>';
            });
            $('.tbody').html(html);
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function AddTest() {
    var TestObj = {
        TestID=$('TestID').val(),
        TestName=$('TestName').val(),
        CatID=$('CatID').val(),
        UnitID=$('UnitID').val(),
        NormalRange=$('NormalRange').val(),
        PatientName=$('PatientName').val(),
        DoctorName=$('DoctorName').val(),
        Contact=$('Contact').val(),
        Gender=$('Gender').val(),
        TestDate=$('TestDate').val()
    };
    $.ajax({
        url:,
        type: "Post",
        data: JSON.stringify(TestObj),
        contentType: "application/json;charset=utf-8",
        dataType: "JSON",
        success: function (res) {
            LoadTestData();
        },
        error: function (err) {
            alert(err.responseText);
        }
    });
}
function GetTestByID(ID) {
    $.ajax({
        url:,
        type: "Get",
        contentType: "application/json;charset=utf-8",
        dataType: "JSON",
        success: function (res) {

            $('TestID').val(res.TestID),
                $('TestName').val(res.TestName),
                $('CatID').val(res.CatID),
                $('UnitID').val(res.UnitID),
                $('NormalRange').val(res.NormalRange),
                $('PatientName').val(res.PatientName),
                $('DoctorName').val(res.DoctorName),
                $('Contact').val(res.Contact),
                $('Gender').val(res.Gender),
                $('TestDate').val(res.TestDate)
        },
        error: function (err) {
            alert(err.responseText);
        }
    })
}
function Delete(ID) {
    if (confirm("Do you want to delete this item?")) {
        $.ajax({
            url:,
            type: "Post",
            contentType: "application/json;charset=utf-8",
            dataType: "JSON",
            success: function (res) {
                LoadTestData();
            },
            error: function (err) {
                alert(err.responseText);
            }
        });
    }
}
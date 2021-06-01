////$(document).ready(function () {

////    var pageSize = 5;
////    var pageNumber = 1;
////    GetDataTable(pageSize, pageNumber, "");


////    /**
////     * 
////     * @param {any} pageSize
////     * @param {any} pageNumber
////     * @param {any} Search
////     */
////    function GetDataTable(pageSize, pageNumber, Search) {
////        debugger
////        var getViewData = new Object();
////        getViewData["pageSize"] = pageSize;
////        getViewData["pageNumber"] = pageNumber;
////        getViewData["Search"] = Search;
////        console.log(getViewData);
////        $.ajax({
////            url: '/Admin/Admin/_TableView',
////            type: "post",
////            dataType:'html',
////            data: {
////                getViewData : getViewData
////            },
////            success: function (res) {
////                console.log(getViewData);
////                $('.table-view').html('');
////                $('.table-view').append(res);
////            },
////            error: function (error) {

////            }
////        })

////    }

////})

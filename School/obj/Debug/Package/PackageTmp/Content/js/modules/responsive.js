/**
 * Created by Colin on 14-5-24.
 */
define(function(require, exports, module) {
    var $ = require('libs/jquery/jquery.js');
    function clientChange(){
        change();
        window.onresize = change;
        function change(){
           var wClient=$('body').width();
           if(wClient>=992){
               $('#style').attr('href','css/pc/index.css')

           }else if(wClient<992&&wClient>=768){

               $('#style').attr('href','css/ipad/index.css');
           } else if(wClient<=768){
               $('#style').attr('href','css/mobile/index.css');
           }


        }
    }
    exports.clientChange=clientChange;



})

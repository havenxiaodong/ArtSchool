/**
 * Created by Colin on 14-5-25.
 */
define(function(require, exports, module) {
    var $ = require('libs/jquery/jquery.js');
    $('.nav ul').find('li').hover(function(){
        $(this).css('background','#801626');
        $(this).find('ul').stop(true).slideDown();
    },function(){
        $(this).css('background','');
        $(this).find('ul').stop(true).slideUp(10);
    });



})
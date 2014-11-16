define(function(require, exports, module) {
    var $ = require('libs/jquery/jquery.js'); // 使用jquery

    $('.firstNav>li').hover(function(){
        $(this).find('a').css('color','#dc6870');
        $(this).find('ul').stop(true).slideDown();
    },function(){
        $(this).find('a').css('color','#5a5a5a');
        $(this).find('ul').stop(true).slideUp(10);
    });
    $('.secondNav').find('li').hover(function(){
        $(this).find('a').css({color:'#dc6870'});
    },function(){
        $(this).find('a').css({color:'white'});
    })

    var colors=['#30d3cf','#fede74','#eb5a6c','#b45068','#683f5a'];
    $('.con-nav li').hover(function(){
        var index=$(this).index();
        $(this).css({cursor:'pointer',color:'white',background:colors[index]});
    },function(){
        $(this).css({color:'black',background:'white'})
    })


});
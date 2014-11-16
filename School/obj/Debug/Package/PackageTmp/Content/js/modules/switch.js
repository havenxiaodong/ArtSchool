/**
 * Created by Colin on 14-5-25.
 */
define(function(require, exports, module) {
    var $ = require('libs/jquery/jquery.js'); // 使用jquery
    var aLiUl=$('.show li');
    var aLiOl=$('.number li');
    var numb=$('.number');
    var size=aLiUl.size();
    var iNow=0;
    var iWidth=aLiUl.eq(0).width();
    var timer=null;
    var time1=400;
    var time2=3000;
    preWork(aLiUl,size,iWidth);

    function preWork(obj,size,ileft){
        for(var i=1;i<size;i++){
            obj.eq(i).css({left:ileft});
        }
    }
    for(var i=0;i<size;i++){
        aLiOl[i].index=i;
        aLiOl[i].onmouseover=function(){
            $(this).css('cursor','pointer');
            aLiOl.each(function() {
                $(this).attr('class','')
            });
            $(this).attr('class','active');
            if(this.index > iNow){
                aLiUl.eq(this.index).css({left:iWidth});
                aLiUl.eq(iNow).stop().animate({left:-iWidth},time1);
            }
            else if(this.index < iNow){
                aLiUl.eq(this.index).css({left:-iWidth});
                aLiUl.eq(iNow).stop().animate({left:iWidth},time1);
            }
            aLiUl.eq(this.index).stop().animate({left:0},time1);
            iNow = this.index;
        }

    }
    timer=setInterval(change,time2);
    function change(){
        if(iNow==size-1){
            iNow=0
        }else{
            iNow++
        }
        for(var i=0;i<size;i++){
            aLiOl.eq(i).attr('class', '');
        }
        aLiOl.eq(iNow).attr('class', 'active');
        aLiUl.eq(iNow).css({left:iWidth});
        aLiUl.eq(iNow-1).stop().animate({left:-iWidth},time1,function(){
            aLiUl.eq(iNow-1).css({left:iWidth})
        });
        aLiUl.eq(iNow).stop().animate({left:0},time1);

    }
    $('.show li,.number li').hover(function() {

        clearInterval(timer)
    }, function() {
        timer=setInterval(change,time2);
    });



});



/// <reference path="jquery-1.8.2-vsdoc.js" />
/// <reference path="jquery-ui-1.9.2.custom.js"/>

var currentFormat = "";
var lastValue;
var isChanging = false;
function formatToEngineer(val) {
	var exp = Math.floor((Math.log(val) / Math.log(10)) / 3.0) * 3.0;
	var nval = val * Math.pow(10.0, -exp);
	if (nval >= 1000) {
		nval = nval / 1000.0;
		exp = exp + 3;
	}
	if (exp > 0) exp = "+" + exp;
	return nval + "e" + exp;
}
var Cookies = {
	create: function (name, val, days) {
		var expires = '';
		if (days) {
			var now = new Date();
			now.setDate(now.getTime() + (days * 24 * 60 * 60 * 1000));
			expires = "; expires=" + now.toGMTString();
		}
		else expires = "";
		document.cookie = name + "=" + val + expires + "; path=/";
	},
	read: function (name) {
		name = name + "=";
		var ca = document.cookie.split(';');
		for (var i = 0; i < ca.length; i++) {
			var c = ca[i];
			while (c.charAt(0) === ' ') c = c.substring(1, c.length);
			if (c.indexOf(name) === 0) return c.substring(name.length, c.length);
		}
		return null;
	}
};
$.fn.setCursorPosition = function (pos) {
	this.each(function (ind, ele) {
		if (ele.setSelectionRange) {
			ele.setSelectionRange(pos, pos);
		} else if (ele.createTextRange) {
			var range = ele.createTextRange();
			range.collapse(true);
			range.moveEnd('character', pos);
			range.moveStart('character', pos);
			range.select();
		}
	});
	return this;
};
function updateFormat(isPostBack) {
	isChanging = false;
	stopResult();
	lbChange();
	$(fromValueId).focus().setCursorPosition(10000);
	var result = $(toValueId).val();
	switch (currentFormat) {
		case "Decimal":
			if (isPostBack && isPostBack === "no")
				$(toValueId).val(Number(lastValue));
			break;
		case "Scientific":
			$(toValueId).val(Number(result).toExponential(10));
			break;
		case "Engineer":
			$(toValueId).val(formatToEngineer(Number(result)));
			break;
		default: break;
	}
	if (!isPostBack || isPostBack !== "no")
		lastValue = result;
}
function lbChange() {
	Cookies.create('lastCategory', $(catListBox).children('option:selected').val());
	//console.log(Cookies.read('lastCategory'));
}
function startResult() {
	$(toValueId).stop().animate({
		backgroundColor: "#454545"
	}, 250);
}
function stopResult() {
	$(toValueId).stop().animate({
		backgroundColor: "#FFFFFF"
	}, 150);
}
$(function () {
	$("#btnSwap").button().click(function (e) {
		var fromOld = $(fromUnitDDL).val();
		$(fromUnitDDL).val($(toUnitDDL).val());
		$(toUnitDDL).val(fromOld);
		doValuePost();
		e.preventDefault();
	});
	$("#options_icon").click(function (e) {
		var optOpen = $(this).data('open');
		if (optOpen == "open") {
			$(this).removeClass('selected');
			$(this).data('open', 'closed');
		} else {
			$(this).addClass('selected');
			$(this).data('open', 'open');
		}
	});
	Sys.WebForms.PageRequestManager.getInstance().add_endRequest(updateFormat);
	Sys.WebForms.PageRequestManager.getInstance().add_beginRequest(function () {
		if (!isChanging) {
			startResult();
		}
		isChanging = true;
	});
	if (currentFormat === "") {
		var last = Cookies.read('lastFormat');
		if (last !== null) currentFormat = last;
		else currentFormat = "Decimal";
		$(".radioOpt").find('input').each(function () {
			if ($(this).val() === currentFormat) {
				$(this).parent().addClass('radioOn');
				$(this).parent().parent().find('label').addClass('radioLabelOn');
				$(this).parent().parent().prop('checked', true);
			}
		});
	}
	var catCook = Cookies.read('lastCategory');
	if (catCook) {
		//console.log('found cookie! value=' + catCook);
		$(catListBox).children().each(function () {
			if ($(this).val() === catCook) {
				//console.log('val should be: ' + $(this).val());
				$(catListBox).val($(this).val());
				__doPostBack(catListBoxRaw, '');
			}
		});
	}
	$(".radioOpt").on('click', function () { //done
		$(this).find('input').attr('checked', 'checked');
		$(".radioOpt").each(function () {
			var $inp = $(this).find('input');
			if ($inp.is(':checked')) {
				currentFormat = $inp.val();
				Cookies.create('lastFormat', currentFormat, 7);
				$(this).find("div").addClass("radioOn");
				$(this).find('label').addClass('radioLabelOn');
			} else {
				$(this).find("div").removeClass("radioOn");
				$(this).find('label').removeClass('radioLabelOn');
			}
		});
		updateFormat("no");
	});
	$(catListBox).on('change', lbChange);
});
//done from here
var lastTimeout = null;
function doValuePost() {
	__doPostBack(toValueIdRaw, '');
}
function startPostDelay(evee) {
	if (lastTimeout !== null) clearTimeout(lastTimeout);
	startResult();
	lastTimeout = setTimeout(doValuePost, 150);
}
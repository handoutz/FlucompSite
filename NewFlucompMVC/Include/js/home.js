/// <reference path="jquery-1.7.2-vsdoc.js" />
/// <reference path="Firebug-vsdoc.js" />
String.prototype.format = function () {
	var formatted = this;
	for (var i = 0; i < arguments.length; i++) {
		var regexp = new RegExp('\\{' + i + '\\}', 'gi');
		formatted = formatted.replace(regexp, arguments[i]);
	}
	return formatted;
};
String.prototype.trim = function () {
	return this.replace(/^\s+|\s+$/g, "");
};
$(function () {
	$(".scriptEnabled").show();
	$(".navTab").click(function (event) {
		//$(".selected").removeClass('selected').css('background-color', 'transparent').addClass("notSelected");
		//$(this).removeClass('notSelected').addClass('selected').css('background-color', '#f5f5f5');
		$(".selected").removeClass('selected').addClass('notSelected');
		$(this).removeClass('notSelected').addClass('selected');
		var href = "";
		if ($(this).get(0).tagName !== "a") {
			href = $("a", this).attr('href');
		} else {
			href = $(this).attr('href');
		}
		loadTab(href);
		event.preventDefault();
	});
	//$(".selected").css('background-color', '#f5f5f5');
	$.ajaxSetup({
		cache: false,
		async: true,
		type: "GET",
		error: function (xhr, a, b) {
			console.log([a, b]);
			loadingProduct = false;
		}
	});
});
var curTab = null;
function loadTab(href) {
	var speed = 200;
	$.ajax({
		url: href,
		cache: false,
		async: true,
		type: "GET",
		beforeSend: function (xhr) {
			var h = $("#contentArea").height();
			$("#bottom").stop().animate({
				height: h + 'px'
			}, speed);
			$("#bottom").css('min-height', '0px');
			$("#contentArea").stop().fadeOut(speed);
		},
		success: function (data) {
			$("#contentArea").promise().done(function () {
				$(this).html("");
				var content = $("<div/>").append(data).css({
					'position': 'absolute',
					'visibility': 'hidden',
					'display': 'block'
				});
				$('body').append(content);
				var h = content.height() + 128;
				content.remove();
				$("#bottom").stop().animate({
					height: h + 'px'
				}, speed, function () {
					$("#contentArea").append(data).fadeIn(speed);
				});
				document.title = pageTitle;
			});
		}
	});
}
function loadProduct(href, objRef) {
	var speed = 200;
	$.ajax({
		url: href,
		context: {
			obj: objRef
		},
		beforeSend: function () {
			if (this.obj.hasClass('selectedProduct'))
				return false;
			$("#bottom").css('min-height', $("#bottom").height() + "px");
			$(".selectedProduct").removeClass("selectedProduct");
			this.obj.addClass("selectedProduct");
			$("#contentContainer").stop().fadeOut(speed);
		},
		success: function (data) {
			$("#contentContainer").promise().done(function () {
				$(this).html(data).fadeIn(speed);
			});
		},
		complete: function () {
			loadingProduct = false;
		}
	});
}
var loadingProduct = false;
function initProductList() {
	$(".product a").off('click').on('click', function (eve) {
		eve.preventDefault();
	});
	$(".product").off('click').on('click', function (eve) {
		var href = $(this).data('href');
		loadProduct(href, $(this));
	});
}
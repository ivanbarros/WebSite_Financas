window.onload = function () {
	//PIE CHART
	var ctx = document.getElementById('pie_chart').getContext('2d');
	window.myPie = new Chart(ctx, config);
	//FIM PIE CHART

	//LINE BAR
	var lineBarCtx = document.getElementById('line_chart').getContext('2d');
	window.myLine = new Chart(lineBarCtx, configure);
	//FIM LINE BAR
};
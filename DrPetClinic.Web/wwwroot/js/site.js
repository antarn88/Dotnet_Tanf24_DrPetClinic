async function changeMonth(direction, monthMap) {
  const url = new URL(window.location.href);
  let year = parseInt(url.pathname.split("/")[2]);
  let month = url.pathname.split("/")[3];

  let monthNumber = isNaN(parseInt(month)) ? monthMap[month.toLowerCase()] : parseInt(month);
  let isNumericMonth = !isNaN(parseInt(month));

  if (isNaN(monthNumber) || (!isNumericMonth && !monthMap.hasOwnProperty(month.toLowerCase()))) {
    console.warn("Érvénytelen hónap, URL nem frissül.");
    return;
  }

  if (direction === "previous") {
    monthNumber--;
    if (monthNumber < 1) {
      monthNumber = 12;
      year--;
    }
  } else if (direction === "next") {
    monthNumber++;
    if (monthNumber > 12) {
      monthNumber = 1;
      year++;
    }
  }

  const monthNames = Object.keys(monthMap);
  const newMonthSegment = isNumericMonth ? monthNumber.toString().padStart(2, "0") : monthNames[monthNumber - 1];
  const newUrl = `/Rendelesek/${year}/${newMonthSegment}`;

  window.history.pushState({}, "", newUrl);

  try {
    const response = await fetch(newUrl);
    if (!response.ok) throw new Error("Adatok lekérése sikertelen.");

    const data = await response.text();
    const parser = new DOMParser();
    const doc = parser.parseFromString(data, "text/html");
    const newTable = doc.querySelector(".consultation-times-monthly-table");
    const consultationTimesMonthlyTable = document.querySelector(".consultation-times-monthly-table");

    if (consultationTimesMonthlyTable && newTable) {
      consultationTimesMonthlyTable.innerHTML = newTable.innerHTML;
    }
  } catch (error) {
    console.error("Hiba történt:", error);
  }
}

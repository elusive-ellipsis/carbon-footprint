var answer;
var carbon = 30;
console.log(carbon);
public static int whichAnswer (int carbon) {
  if (document.getElementById('answer1').checked) {
    carbon = carbon + 4;
    answer = document.getElementById('answer1').value;
  }
  else if (document.getElementById("answer2").checked){
    carbon = carbon + 3;
    answer = document.getElementById("answer2").value;
  }
  else if (document.getElementById("answer3").checked){
    carbon = carbon + 2;
    answer = document.getElementById("answer3").value;
  }
  else if (document.getElementById("answer4").checked){
    carbon = carbon + 1;
    answer = document.getElementById("answer4").value;
  }
  console.log(carbon);
  console.log(answer);
  return carbon;
}
function endScore() {
  document.getElementById("carbonPoints").innerHTML = "Your carbon footprint score: " + carbon;
  if (carbon < 20) {
    document.getElementById("carbonGrade").innerHTML = "You're an eco-warrior!";
    document.getElementById("nextSteps").innerHTML = "If you want to go even further, be inspired by these ideas:";
  }
  else if (carbon < 40) {
    document.getElementById("carbonGrade").innerHTML = "Pretty good!";
    document.getElementById("nextSteps").innerHTML = "How about taking the next step towards a smaller carbon footprint and having a look at these resources?";
  }
  else {
    document.getElementById("carbonGrade").innerHTML = "Room for improvement...";
    document.getElementById("nextSteps").innerHTML = "To get started on the path to greater environmental friendliness, why don't you try the following?";
  }
  console.log("Done");
}

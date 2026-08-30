//
// This is only a SKELETON file for the 'Line Up' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const format = (name, number) => {
  number = number.toString();
  
  if (number.slice(-2) != "11" && number.at(-1) == "1") return `${name}, you are the ${number}st customer we serve today. Thank you!`;
  else if (number.slice(-2) != "12" && number.at(-1) == "2") return `${name}, you are the ${number}nd customer we serve today. Thank you!`;
  else if (number.slice(-2) != "13" && number.at(-1) == "3") return `${name}, you are the ${number}rd customer we serve today. Thank you!`;
  else return `${name}, you are the ${number}th customer we serve today. Thank you!`;
};

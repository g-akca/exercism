//
// This is only a SKELETON file for the 'Line Up' exercise. It's been provided as a
// convenience to get you started writing code faster.
//

export const format = (name, number) => {
  number = number.toString();
  let suffix = "th";
  
  if (number.slice(-2) != "11" && number.at(-1) == "1") suffix = "st";
  else if (number.slice(-2) != "12" && number.at(-1) == "2") suffix = "nd";
  else if (number.slice(-2) != "13" && number.at(-1) == "3") suffix = "rd";
  
  return `${name}, you are the ${number}${suffix} customer we serve today. Thank you!`;
};

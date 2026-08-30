/// <reference path="./global.d.ts" />
// @ts-check

/**
 * Implement the functions needed to solve the exercise here.
 * Do not forget to export them so they are available for the
 * tests. Here an example of the syntax as reminder:
 *
 * export function yourFunction(...) {
 *   ...
 * }
 */


export function cookingStatus(remainingTime) {
  if (remainingTime === undefined) return "You forgot to set the timer.";
  
  if (remainingTime == 0) return "Lasagna is done.";
  else return "Not done, please wait.";
}

export function preparationTime(layers, timePerLayer = 2) {
  return layers.length * timePerLayer;
}

export function quantities(layers) {
  let noodles = 0;
  let sauce = 0;
  for (let layer of layers) {
    if (layer == "noodles") noodles += 50;
    else if (layer == "sauce") sauce += 0.2;
  }

  return {
    noodles: noodles,
    sauce: sauce
  }
}

export function addSecretIngredient(friendList, myList) {
  myList.push(friendList.at(-1));
}

export function scaleRecipe(recipe, portions) {
  let newRecipe = {};
  
  for (let key in recipe) {
    newRecipe[key] = recipe[key] * portions / 2;
  }

  return newRecipe;
}
// @ts-check

/**
 * Implement the classes etc. that are needed to solve the
 * exercise in this file. Do not forget to export the entities
 * you defined so they are available for the tests.
 */

function Size(width = 80, height = 60) {
  this.width = width;
  this.height = height;
}

Size.prototype.resize = function(width, height) {
  this.width = width;
  this.height = height;
}

function Position(x = 0, y = 0) {
  this.x = x;
  this.y = y;
}

Position.prototype.move = function(newX, newY) {
  this.x = newX;
  this.y = newY;
}

function ProgramWindow() {
  this.screenSize = new Size(800, 600);
  this.size = new Size();
  this.position = new Position();
}

ProgramWindow.prototype.resize = function(newSize) {
  let width = Math.max(1, newSize.width);
  let height = Math.max(1, newSize.height);

  const maxWidth = this.screenSize.width - this.position.x;
  const maxHeight = this.screenSize.height - this.position.y;

  this.size.width = Math.min(width, maxWidth);
  this.size.height = Math.min(height, maxHeight);
}

ProgramWindow.prototype.move = function(newPosition) {
  let x = Math.max(0, newPosition.x);
  let y = Math.max(0, newPosition.y);

  const maxX = this.screenSize.width - this.size.width;
  const maxY = this.screenSize.height - this.size.height;

  this.position.x = Math.min(x, maxX);
  this.position.y = Math.min(y, maxY);
}

function changeWindow(programWindow) {
  programWindow.resize(new Size(400, 300));
  programWindow.move(new Position(100, 150));
  return programWindow;
}

export { Size, Position, ProgramWindow, changeWindow };
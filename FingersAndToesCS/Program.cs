using FingersAndToesCS;

var model = new FingerAndToeCollection();
View.Update(model);
model.ToggleIsFingerOrToeDone(0);
model.ToggleIsFingerOrToeDone( 5);
View.Update(model);

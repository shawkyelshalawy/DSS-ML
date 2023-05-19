from flask import Flask, render_template, url_for, request
import pickle


xg_Predicition_Model = Flask(__name__)

xg_model = pickle.load(
    open(r'C:\Users\lenovo\Desktop\data\XG\XG Model.pkl', 'rb'))

input_mapping_location = {
    # "Attacking half": 0,
    "fast_break": 0,
    "Centre of the box": 0,
    "Left wing": 0,
    "Right wing": 0,
    # "Difficult angle and long range": 0,
    "Difficult angle on the left": 0,
    "Difficult angle on the right": 0,
    "Left side of the box": 0,
    "Left side of the six yard box": 0,
    "Right side of the box": 0,
    "Right side of the six yard box": 0,
    "Very close range": 0,
    "Penalty spot": 0,
    "Outside the box": 0,
    "Long range": 0,
    "More than 35 yards": 0,
    "More than 40 yards": 0,
}


input_mapping_bodypart = {
    "right foot": 0,
    "left foot": 0,
    "head": 0,
}

input_mapping_assist_method = {
    "None": 0,
    "Pass": 0,
    "Cross": 0,
    "Headed pass": 0,
    "Through ball": 0,
}

input_mapping_situation = {
    "Open play": 0,
    "Set piece": 0,
    "Corner": 0,
    "Free kick": 0,
}

data_input = []
x = 0


@xg_Predicition_Model.route("/")
def HomePage():
    return render_template(r'home_page.html')


@xg_Predicition_Model.route("/process_form", methods=['POST'])
def process_form():
    data_input = []

    selected_location = request.form['location']
    if selected_location == 'Choose the location':
        data_input.extend(input_mapping_location.values())
    else:
        input_mapping_location[selected_location] = 1
        data_input.extend(input_mapping_location.values())

#########################
    selected_bodypart = request.form['bodypart']
    if selected_bodypart == 'Body Part':
        data_input.extend(input_mapping_bodypart.values())
    else:
        input_mapping_bodypart[selected_bodypart] = 1
        data_input.extend(input_mapping_bodypart.values())
########################
    selected_assist_method = request.form['assist_method']
    if selected_assist_method == 'Assist Method':
        data_input.extend(input_mapping_assist_method.values())
    else:
        input_mapping_assist_method[selected_assist_method] = 1
        data_input.extend(input_mapping_assist_method.values())
#######################
    selected_situation = request.form['situation']
    if selected_situation == 'Situation':
        data_input.extend(input_mapping_situation.values())
    else:
        input_mapping_situation[selected_situation] = 1
        data_input.extend(input_mapping_situation.values())
########################
    x = xg_model.predict([data_input])
    if x == [1]:
        return render_template(r'goal.html')
    else:
        return render_template(r'not_goal.html')


if __name__ == "__main__":
    xg_Predicition_Model.run(debug=True, port=8000)

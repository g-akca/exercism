"""Functions which helps the locomotive engineer to keep track of the train."""


def get_list_of_wagons(*args):
    return [*args]


def fix_list_of_wagons(each_wagons_id, missing_wagons):
    [a, b, *rest] = each_wagons_id
    [locomotive, *rest] = rest

    return [locomotive, *missing_wagons, *rest, a, b]


def add_missing_stops(route, **kwargs):
    return {**route, "stops": [*kwargs.values()]}


def extend_route_information(route, more_route_information):
    return {**route, **more_route_information}


def fix_wagon_depot(wagons_rows):
    return list(map(list, zip(*wagons_rows)))
